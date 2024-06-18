from fastapi import FastAPI
from fastapi.staticfiles import StaticFiles
from enum import Enum
from pydantic import BaseModel
from products import products
from users import user, user_db
from auth import auth2, authJWT

# Modelo no funcional
class ModelName(str, Enum):
  xuning = "xuning"
  resnet = "resnet"

# Utilización del Api
my_steeps = FastAPI()

# Enruta hasta productos 
my_steeps.include_router(products.product)

# Enruta hasta los datos del usuario
my_steeps.include_router(user.user)

# Entruta hasta el login
my_steeps.include_router(auth2.login_auth)

# Entruta hasta el login de jwt
my_steeps.include_router(authJWT.login_auth_jwt)

# enruta al api que esta conectada a la base de datos
my_steeps.include_router(user_db.user_db)

# all names of files, aways is at English 
# Llamado de archivos staticos 
my_steeps.mount("/women", StaticFiles(directory="static"), name="static") #! Llamas directamente una imagen

# el primer Hello world
@my_steeps.get("/")
async def hello_world():
  return {"message": "Hello, world!"}

# retorna un dato 
@my_steeps.get("/item/{item_id}")
async def read_item(item_id:int):
  return {"item_id": item_id}


@my_steeps.get("/item/{model_name}") #! esto tiene un error enorme
async def read_model(model_name: ModelName):
  return {"model": model_name, "message": "Unknown model"}

  