const entrar_btn = document.querySelector('#entrar-button');
const inscrever_se_btn = document.querySelector('#inscrever-se-button');
const container = document.querySelector('.container');

inscrever_se_btn.addEventListener('click', () => {
  container.classList.add('inscrever-se-mode');
});

entrar_btn.addEventListener('click', () => {
  container.classList.remove('entrar-mode'); // Remova a classe inscrever-se-mode
});

function logar(){

  var login = document.getElementById('login').value;
  var senha = document.getElementById('senha').value;

  if(login == "admin" && senha == "admin"){
      alert('Sucesso');
      location.href = "home.html";
  }else{
      alert('Usuario ou senha incorretos');
  }

}