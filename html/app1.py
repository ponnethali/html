from flask import Flask,request,render_template
import pickle
import mysql.connector
import json
import os
from flask import jsonify
#from flaskext.mysql import MySQL

app = Flask(__name__)

#mysql = MySQL()

config = {
        'user': 'root',
        'password': os.getenv("db_root_password"),
        'host': os.getenv("MYSQL_SERVICE_HOST"),
        'port': int(os.getenv("MYSQL_SERVICE_PORT")),
        'database': os.getenv("db_name")
    }

@app.route('/')
def hello_world():
    return render_template("login.html")
@app.route('/form_login',methods=['POST','GET'])
def login():
    name1=request.form['username']
    pwd=request.form['password']

    sql=" SELECT user_name FROM users"
    query="SELECT user_password FROM users WHERE user_name = %s "
    try:
        connection = mysql.connector.connect(**config)
        cursor = connection.cursor()
        cursor.execute(sql)
        data = [{name} for (user_name) in cursor]
        if name1 not in (data):
	        return render_template('login.html',info='Invalid User')
        else:
            cursor.execute(query,name1)
            pass1=cursor.fetchall()

            if pwd != pass1 :
                return render_template('login.html',info='Invalid Password')

            else:
	            return render_template('home.html',name=name1)
    except Exception as exception:
        return render_template('login.html',info='Exception')


    
    cursor.close()
    connection.close()
