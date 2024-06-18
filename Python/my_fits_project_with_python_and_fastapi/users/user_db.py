from fastapi import APIRouter, HTTPException, status
from conect_data_base.models.user import User
from conect_data_base.client import db_clien
from conect_data_base.schemas.user import user_schema, users_schema
from bson import ObjectId
""" Aqui se agrupa los enpoints 
  El prefix es la ruta por defecto y el tags es la etiqueta que agrupa los enpoins
  hechos en este modulo
"""
user_db = APIRouter(prefix="/users_db", tags=["Users DB"])

# Este es el modelo de usuarios
#este enpoint retorna por defecto los usuarios de la base de datos 
@user_db.get("/", response_model=list[User])
async def user_model():
  return users_schema(db_clien.local.users.find())



# ! Path and Query
"""
  ? Path, cuando se sabe que un parametro es fijo
  ? Query, Cuando no hay parametros que nos se saben ni el tipo
  ! Las buenas practivas es cuando todo sea fijo
"""
# user Data o base de datos
user_list = [""]

#path
# retorna el usuario buscado
@user_db.get("/{id}")
async def user_found(id: str):
  return search_user("_id", ObjectId(id))
  

#querry
#retorna el usuario buscado
@user_db.get("/userquery/")
async def userquerry(id: str):
  return search_user("_id", ObjectId(id))

# Busca los usuarios por el id
def search_user_by_email(email:str):
  try:
    user=db_clien.local.users.find_one({"email": email})
    return User(**user_schema(user))
  except:
    return {"error": "user not found"}
 
 
def search_user(field:str, key):
  try:
    user= db_clien.local.users.find_one({field: key})
    return User(**user_schema(user))
  except:
    return {"error": "user not found"}
    

"""CRUD
  ? este enpoint agrega los usuario
"""
@user_db.post("/add/")
async def user_post(user: User):
  try:
    user_dict = dict(user)
    del user_dict["id"]
    id = db_clien.local.users.insert_one(user_dict).inserted_id
    new_user=user_schema(db_clien.local.users.find_one({"_id": id}))
    return User(**new_user)
  except:
    raise HTTPException(status_code=status.HTTP_404_NOT_FOUND, detail="The user with this email alredy exist")

# este actualiza el usuario
@user_db.put("/update/")
async def user_put(user: User):
  try:
    user_dic = dict(user)
    del user_dic["id"]
    db_clien.local.users.find_one_and_replace({"_id": ObjectId(user.id)}, user_dic)
  except:
    return {"messages": "User not found"}
  
  return search_user("_id", ObjectId(user.id))
  
#Este Elimina el usuario
@user_db.delete("/delete/{id}", status_code=status.HTTP_205_RESET_CONTENT)
async def user_delete(id: str):
  found = db_clien.local.users.find_one_and_delete({"_id":ObjectId(id)})
  if not found:
    return {"messages": "User not exist and can´t delete"}
  else:
    return {"messages": "user delete"}
 