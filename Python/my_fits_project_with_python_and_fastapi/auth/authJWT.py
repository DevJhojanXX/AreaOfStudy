from fastapi import APIRouter, Depends, HTTPException, status
from pydantic import BaseModel
from fastapi.security import OAuth2PasswordBearer, OAuth2PasswordRequestForm

# se importa los encirptadores
# Jwt es el que genera el token
from jose import jwt, JWTError

# passlib es el que da el contexto de la cryptografica
from passlib.context import CryptContext

# se importa el data time ya que se necesita manejar el tiempo
from datetime import datetime, timedelta

# Se pone el contexto que se va a utilizar en el algoritmo de encritación
ALGORITHM = "HS256"

# Se agrega el tiempo de activación de cada token '1 = 1 minuto'
ACCESS_TOKEN_DURATION = 1440

# Se pone el secreto por 'openssl rand -hex 32' => ese codigo se pone el bash
SECRET = "4bd3cad5e8118195a55fcf086d8710fa65d44a2f571d58d9809858dd234847ce"

""" Aqui se agrupa los enpoints 
  El prefix es la ruta por defecto y el tags es la etiqueta que agrupa los enpoins
  hechos en este modulo
"""
login_auth_jwt = APIRouter(prefix="/jwt", tags=["Login JWT"])


# Este es el que envia los criterios de autenticación a cualquier enpoint
oauth2 = OAuth2PasswordBearer(tokenUrl="login")

# Se pone el contesto que se utilizara en la criptografia
crypt = CryptContext(schemes=["bcrypt"])


"""
Autenticacion: Es cuando estes registrado en una plataforma
Autorizacion: Es cuando tienes permisos en dicha plataforma 
"""

# Modelos de la base de datos
class User(BaseModel):
  username: str
  full_name: str
  email: str
  disable: bool

class UserDB(User):
  password:str

class AuthUser(BaseModel):
  username: str
  password: str  


# Base de datos
users_list = {
  "Jhojan": {
    "username": "Jhojan",
    "full_name": "jhojan Toro",
    "email": "jhojan@email.com",
    "disable": False,
    "password": "$2a$12$RtZ2xJ4jSX/ejSRB/zE9le6FrK6mE3nuyVSrJnDdnlwzWpNtr1Xf."
  }, 
  "Jhojan2":{
    "username": "Jhojan2",
    "full_name": "jhojan2 Toro",
    "email": "jhojan2@email.com",
    "disable": True,
    "password": "$2a$12$EIEZpQ2yeWwVrvlQZVCw6ee9TAtxWJd7fhxto4PyDCduA8sSDDB5W"
  },
}

# Buscador del usuairo por su nombre desde la utenticación
def search_data(username: str):
  # si el usuairo existe retorna su usuario y la contraceña
  if username in users_list:
    user_data = users_list[username]
    return AuthUser(username=str(user_data["username"]), password=str(user_data["password"]))
   
# Buscador regular del usuario 
def search_user(username: str):
  if username in users_list:
    user_data = users_list[username]
    return User(
      username=str(user_data["username"]),
      full_name=str(user_data["full_name"]),
      email=str(user_data["email"]),
      disable=bool(user_data["disable"]),
    )

# Autentica el suario traves del token
async def auth_user(token: str =Depends(oauth2)):
  # Exepción reutilizable
  exception= HTTPException(
          status_code=status.HTTP_401_UNAUTHORIZED, 
          detail="User not Authorized",
          headers={"WWW-Authenticate":"Bearer"}
        )
  try:
    #desecripta el usuario por el token
    username = jwt.decode(token, SECRET, algorithms=[ALGORITHM])
    if username is None:
      raise exception 
  except JWTError:
      raise exception
  
  # retorna el nombre del usuairo 
  return search_user(username["sub"])
    
# Funcion en la que un usuario es utilizado desde su modelo 
async def current_user(user: User = Depends(auth_user)):
  # si el usuairo no esta activo devolvera la excepcion 
  if user.disable:
    raise HTTPException(
        status_code=status.HTTP_400_BAD_REQUEST, 
        detail="User Inactive",
      ) 
  # retorna el usuario
  return user

# Se hace un logín reguar desde un usuario y una contraceña 
@login_auth_jwt.post("/login")
async def authentication(form: OAuth2PasswordRequestForm = Depends()):
  # Busca desde la base de datos
  user_db= users_list.get(form.username)
  
  # si no exite el usaurio en la base de dato devuelve un bad reques
  if not user_db:
    raise HTTPException(
        status_code=status.HTTP_400_BAD_REQUEST, 
        detail="User not found"
      )
  
  # Busca directamente el usuario
  user = search_data(form.username)
  
  # Verifica que el usairo exista
  if not crypt.verify(form.password, user.password):
    raise HTTPException(
        status_code=status.HTTP_400_BAD_REQUEST, 
        detail="password is incorrect"
      )
 
  # el lo que se mandara a encriptar
  access_token = {
    "sub": user.username,
    "exp": datetime.utcnow() + timedelta(minutes=ACCESS_TOKEN_DURATION)
  } 

  # el token es algo que es encriptado
  # Retorna el token el cual tambien utiliza el Secreto y el contexto del Algoritmo
  return {"access_token": jwt.encode(access_token, SECRET , algorithm=ALGORITHM,), "token_type":"bearer"}

# este retorna el usuairo
@login_auth_jwt.get("/users/me")
async def me(user: User = Depends(current_user)):
  return user
  