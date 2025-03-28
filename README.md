Linhas de comando usadas no gitbash:
![print1](https://github.com/user-attachments/assets/d41a1ac3-e6c7-4718-b7b9-d1b21ef07bc8)

Comecei conferindo se meu nome e email já estavam corretamente configurados no GitBash usando git config --global user.name e git config --global user.email

Copiei o caminho da pasta que estava os meus exercícios e entrei usando cd (Ctrl+Shift+Insert) <---- atalho para colar no gitbash

Inicializei o git na pasta do meu trabalho com: git init

mudei a branch de master para main usando : git branch -m master main

adicionei os arquivos do meu projeto localmente usando: git add .

![print2](https://github.com/user-attachments/assets/5f63859a-01fc-4397-b5f9-ae7cf7b25d33)

Fiz o primeiro commit do projeto --> git commit -m "First Commit"

![print3](https://github.com/user-attachments/assets/126531fd-0a2b-4532-9159-90023cd88e59)

Conectei o repositório remoto com o repositório local usando : git remote add origin <caminho do repositório no github>

e finalmente subi o primeiro commit para o GitHub usando : git push origin main
sendo o origin o caminho que foi definido anteriormente com o git remote add origin, e a main a branch que estamos utilizando

depois só dei uma conferida no commit usando: git status
