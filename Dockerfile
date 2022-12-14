ARG MYAPP_IMAGE=aliponneth/flask-api-demo:main-a465c8c
FROM $MYAPP_IMAGE

FROM python:3.7.4-alpine3.10
RUN pip install flask
RUN pip install redis
ADD app.py /
ADD html/templates/ /
WORKDIR /
EXPOSE 5000
CMD ["python", "app.py", "--host=127.0.0.0"]
