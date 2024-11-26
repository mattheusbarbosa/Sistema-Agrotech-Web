function bloquearCampos(bloqueado) {
    const campos = document.querySelectorAll('#nome, #cpf, #nome_usuario, #senha_usuario');
    campos.forEach(campo => campo.disabled = bloqueado);
    document.querySelector('.salvar').disabled = bloqueado;
    document.getElementById('excluir').disabled = bloqueado;
}


bloquearCampos(true);


function gerarNovoId() {
    return Math.floor(Math.random() * 10000) + 1; 
}


document.addEventListener('DOMContentLoaded', function () {
    const campoId = document.getElementById('id');
    campoId.value = gerarNovoId(); 
});


document.getElementById('novo').addEventListener('click', function () {
    const campoId = document.getElementById('id');
    campoId.value = gerarNovoId(); 
    bloquearCampos(false);         
    this.disabled = true;           
    document.getElementById('excluir').disabled = false; 
});


document.getElementById('excluir').addEventListener('click', function () {
    
    document.getElementById('nome').value = '';
    document.getElementById('cpf').value = '';
    document.getElementById('nome_usuario').value = '';
    document.getElementById('senha_usuario').value = '';

    bloquearCampos(true);          
    document.getElementById('novo').disabled = false;    
});
