from fastapi import APIRouter
from pydantic import BaseModel

""" Aqui se agrupa los enpoints 
  El prefix es la ruta por defecto y el tags es la etiqueta que agrupa los enpoins
  hechos en este modulo
"""
user = APIRouter(prefix="/users", tags=["Users"])

# Este es el modelo de usuarios
class User(BaseModel):
  id: int
  name:str
  age:int



#este enpoint retorna por defecto los usuarios de la base de datos 
@user.get("/")
async def user_model():
  return {"messages":"Ok 200","List":user_list}



# ! Path and Query
"""
  ? Path, cuando se sabe que un parametro es fijo
  ? Query, Cuando no hay parametros que nos se saben ni el tipo
  ! Las buenas practivas es cuando todo sea fijo
"""
# user Data o base de datos
user_list = [
 User( id=1, name= "admin", age=2),
 User( id=2, name= "Marco", age=4)
]

#path
# retorna el usuario buscado
@user.get("/user/{id}")
async def user_found(id: int):
  return search_user(id)

#querry
#retorna el usuario buscado
@user.get("/userquery/")
async def userquerry(id: int):
  return search_user(id)

# Busca los usuarios por el id
def search_user(id:int):
  users = filter(lambda user: user.id == id, user_list)
  try:
    return list(users)[0]
  except:
    return {"error": "User not found"}

"""CRUD
  ? este enpoint agrega los usuario
"""
@user.post("/add/")
async def user_post(user: User):
  if type(search_user(user.id)) == User:
    return {"messages": "User al ready exist"}
  else:
    user_list.append(user)
    return {"messages": "User added", "body": user}
   

# este actualiza el usuario
@user.put("/update/")
async def user_put(user: User):
  found =False
  for index, save_user in enumerate(user_list):
    if save_user.id == user.id:
      user_list[index] = user
      found = True
      return {"messages": "User update", "body": user}
  
  if not found:
    return {"messages": "User not found"}
  
#Este Elimina el usuario
@user.delete("/deleted/{id}")
async def user_delete(id: int):
  found = False
  for index, save_user in enumerate(user_list):
    if save_user.id == id:
      del user_list[index]
      found = True
      return {"messages": "User deleted", "list": user_list}
    
  if not found:
    return {"messages": "User not found"}
  