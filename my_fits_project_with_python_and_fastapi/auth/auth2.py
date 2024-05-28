from fastapi import APIRouter, Depends, HTTPException, status
from pydantic import BaseModel
from fastapi.security import OAuth2PasswordBearer, OAuth2PasswordRequestForm


""" Aqui se agrupa los enpoints 
  El prefix es la ruta por defecto y el tags es la etiqueta que agrupa los enpoins
  hechos en este modulo
"""
login_auth = APIRouter(prefix="/login", tags=["Login"])

# Este es el que envia los criterios de autenticación a cualquier enpoint
oauth2 = OAuth2PasswordBearer(tokenUrl="auth")

"""
Autenticacion: Es cuando estes registrado en una plataforma
Autorizacion: Es cuando tienes permisos en dicha plataforma 
"""

# Es el modelo del usuairo
class User(BaseModel):
  username: str
  full_name: str
  email: str
  disable: bool

# esta clase es separada ya que tiene un dato que debe ser privado
class UserDB(User):
  password:str

# Esta es la clase que manda los datos privados para verificar si existe el usuario 
class AuthUser(BaseModel):
  username: str
  password: str  


# Esta es la base de datos
users_list = {
  "Jhojan": {
    "username": "Jhojan",
    "full_name": "jhojan Toro",
    "email": "jhojan@email.com",
    "disable": False,
    "password": "root"
  }, 
  "Jhojan2":{
    "username": "Jhojan2",
    "full_name": "jhojan2 Toro",
    "email": "jhojan2@email.com",
    "disable": True,
    "password": "root2"
  },
}

#  regtorna los datos privados de usuario
def search_data(username: str):
  if username in users_list:
    user_data = users_list[username]
    return AuthUser(username=str(user_data["username"]), password=str(user_data["password"]))
    
# La funcion busca el usaurio por el username
def search_user(username: str):
  # si existe el user name entonces retornara la mayoria de datos del usuario
  if username in users_list:
    user_data = users_list[username]
    return User(
      username=str(user_data["username"]),
      full_name=str(user_data["full_name"]),
      email=str(user_data["email"]),
      disable=bool(user_data["disable"]),
    )

async def current_user(token: str = Depends(oauth2)):
  # Contiene al usuairo buscado
  user = search_user(token)
  # si no existe retornara una excepcion  
  if not user:
    raise HTTPException(
        status_code=status.HTTP_401_UNAUTHORIZED, 
        detail="User not Authorized",
        headers={"WWW-Authenticate":"Bearer"}
      )
  # si el usuario no esta activo devolvera una excepcion
  if user.disable:
    raise HTTPException(
        status_code=status.HTTP_400_BAD_REQUEST, 
        detail="User Inactive",
      ) 
  # retorna el usuario
  return user
 
# Hace el login de autenticación sencillo
@login_auth.post("/auth")
async def authentication(form: OAuth2PasswordRequestForm = Depends()):
  #busca el usuario directamente desde la base de datos
  user_db= users_list.get(form.username)
  # si no existe el usuario devolvera una excepción
  if not user_db:
    raise HTTPException(
        status_code=status.HTTP_400_BAD_REQUEST, 
        detail="User not found"
      )

  #Busca el usuario de forma normal 
  user = search_data(form.username)
  
  # Verifica si la contraceña es correcta
  if not form.password == user.password:
    raise HTTPException(
        status_code=status.HTTP_400_BAD_REQUEST, 
        detail="password is incorrect"
      )
  
  # el token es algo que es encriptado
  # retorna el token (aunque en este caso solo devuelve el nombre del usuario)
  return {"access_token": user.username, "token_type":"bearer"}

# Busca el usario y este depende de la funcion current_user
@login_auth.get("/users/me")
async def me(user: User = Depends(current_user)):
  #retorna el usuario
  return user
  