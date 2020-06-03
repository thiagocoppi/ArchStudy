# Repositório para estudos de padrões de projetos

**As coisas são meramentes ilustrativas**

Esse repositório tem como principal foco o **aprendizado** e **aplicação** dos conceito para a arquitetura de sistemas. Como aplicação do notification pattern, mediator entre outros...

#Dependências do projeto
Todas as dependencias do projetos encontram-se adicionadas do arquivo docker-compose.yml, para rodar basta uitilizar o comando
  `docker-compose up -d`

Ele irá baixar as dependências que são **sql server**, **kibana** e **elasticsearch**.
Note que esse processo pode demorar alguns minutos, após verificar os container utilizado o comando
  `docker ps - a`

Pode-se utilizar o curl para verificar se o kibana e elasticsearch estão no ar!
 - Elasticsearch (Deve retornar um JSON)
  `curl "http://localhost:9200/_count"`
 - Kibana (Deve retornar um HTML)
  `curl http://localhost:5601 --location`

Algumas partes foram utilziadas dos artigos relatados [Instalando Elasticsearch e Kibana](https://docs.swiftybeaver.com/article/33-install-elasticsearch-kibana-via-docker)

Após realizar a instalação e subir a aplicação é necessário criar um index-pattern para que seja possível visualizar as requests no kibana, feito isso passará a ser possível visualizar as requests que foram disparadas para o método que há no controller
![Kibana messages](./images/messages.jpeg)
