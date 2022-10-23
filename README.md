Projeto criado com o intuito de estudar sobre o docker

Para o container funcionar corretamente, é preciso executar o build antes de 
rodar o comando "docker compose up -d" (o -d força o build da imagem), pois ele espera que a pasta que os arquivos são compilados, exista no projeto

sempre que buildar a aplicação novamente, sempre executar o comando docker compose restart

é preciso atenção a versão do dotnet do projeto, para usar a imagem correta, do sdk e para fazer a configuração correta das pastas
