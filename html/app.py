from flask import Flask,request,render_template
import pickle

import os
from flask import jsonify
from flaskext.mysql import MySQL

app = Flask(__name__)

mysql = MySQL()

# MySQL configurations
app.config["MYSQL_DATABASE_USER"] = "root"
#app.config["MYSQL_DATABASE_PASSWORD"] = ""
app.config["MYSQL_DATABASE_PASSWORD"] = os.getenv("db_root_password")
app.config["MYSQL_DATABASE_DB"] = os.getenv("db_name")
app.config["MYSQL_DATABASE_HOST"] = os.getenv("MYSQL_SERVICE_HOST")
#app.config["MYSQL_DATABASE_PORT"] = 3306
app.config["MYSQL_DATABASE_PORT"] = int(os.getenv("MYSQL_SERVICE_PORT"))
mysql.init_app(app)


@app.route('/')
def hello_world():
    return render_template("login.html")
'''database={}
#database={'ali':'123','james':'123','karthik':'123'}
sql=" SELECT * FROM users"
try:
    conn = mysql.connect()
    cursor = conn.cursor()
    cursor.execute(sql)
    data = cursor.fetchall()
    database=jsonify(data=cursor.fetchall())

    #print(database)
    conn.commit()
    cursor.close()
    conn.close()
    #resp = jsonify("User added successfully!")'''
'''#resp.status_code = 200
    #return resp'''
@app.route('/form_login',methods=['POST','GET'])
def login():
    name1=request.form['username']
    pwd=request.form['password']

    sql=" SELECT user_name FROM users"
    query="SELECT user_password FROM users WHERE user_name = %s "
    try:
        #connection1 = pymysql.connect(host="localhost", user="root", passwd="", database="flaskapi")
        conn = mysql.connect()
        cursor = conn.cursor()
        cur = conn.cursor()
        cursor.execute(sql)
        #print(jsonify(cursor.fetchall()))
        data = [{name} for (user_name) in cursor]

        if name1 not in (data):
	        return render_template('login.html',info='Invalid User')
        else:
            cur.execute(query,name1)
            pass1=((user_password) in cursor)
            if pwd != pass1 :
                return render_template('login.html',info='Invalid Password')
            else:
	            return render_template('home.html',name=name1)
        #database=jsonify(data=cursor.fetchall())
        #print(database)
        conn.commit()
        cursor.close()
        cur.close()
        conn.close()
        '''#resp = jsonify("User added successfully!")'''
        '''#resp.status_code = 200'''
        '''#return resp'''
    except Exception as exception:
        return render_template('login.html',info='Exception')
        '''if name1 not in database:
	    return render_template('login.html',info='Invalid User')
        else:
         if database[name1]!=pwd:
            return render_template('login.html',info='Invalid Password')
            else:
	            return render_template('home.html',name=name1)'''
    #return render_template('login.html',info='running')

if __name__ == '__main__':
    app.run()