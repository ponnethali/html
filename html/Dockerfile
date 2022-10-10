FROM python:3.7.4-alpine3.10
RUN pip install flask
RUN pip install redis
RUN pip install flask-mysql
RUN pip install mysql-connector
ADD app.py /
#ADD templates /
COPY templates/ ./templates/
WORKDIR /
EXPOSE 5000
CMD ["python", "app.py", "--host=127.0.0.0"]