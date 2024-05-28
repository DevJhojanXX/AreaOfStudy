from pymongo import MongoClient

db_clien: MongoClient

try:
  db_clien =  MongoClient('mongodb://localhost:27017/')
except:
  pass