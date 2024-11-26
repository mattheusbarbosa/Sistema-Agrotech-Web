function somenteLetras(event) {
    const tecla = event.key;
    const regex = /^[A-Za-zÀ-ÿ\s]+$/;
    if (!regex.test(tecla) && tecla !== 'Backspace' && tecla !== 'Tab') {
        event.preventDefault();
    }
}


function somenteNumeros(event) {
    const tecla = event.key;
    if (!/[0-9]/.test(tecla) && tecla !== 'Backspace' && tecla !== 'Tab') {
        event.preventDefault();
    }
}


function validarCidade(event) {
    const input = event.target;
    const regex = /[0-9]/;
    if (regex.test(input.value)) {
        input.value = input.value.replace(/[0-9]/g, '');
    }
}

document.addEventListener('DOMContentLoaded', function () {
   
    const nome = document.getElementById('nome_cliente');
    const cpf = document.getElementById('cpf_cnpj');
    const rg = document.getElementById('rg_cliente');
    const numero = document.getElementById('numero');
    const sn = document.getElementById('sn');
    const cep = document.getElementById('CEP');
    const estado = document.getElementById('Estado');
    const cidade = document.getElementById('cidade');

    
    nome.addEventListener('keypress', somenteLetras);

   
    cpf.addEventListener('keypress', somenteNumeros);
    rg.addEventListener('keypress', somenteNumeros);
    numero.addEventListener('keypress', somenteNumeros);
    cep.addEventListener('keypress', somenteNumeros);

    
    cidade.addEventListener('input', validarCidade);

    
    numero.addEventListener('input', function () {
        if (numero.value.length > 0) {
            sn.checked = false;
            sn.disabled = true;
        } else {
            sn.disabled = false;
        }
    });

    sn.addEventListener('change', function () {
        if (sn.checked) {
            numero.value = '';
            numero.disabled = true;
        } else {
            numero.disabled = false;
        }
    });
});


document.addEventListener('DOMContentLoaded', function () {
    const campos = document.querySelectorAll('#pf, #pj, #nomeCliente, #consultar, #cpf_cnpj, #rg_cliente, #data_nascimento, #excluir, #masculino, #feminino, #outros, #rua, #numero, #sn, #complementar, #cep, #bairro, #Estado, #cidade, .salvar');
    const botaoNovo = document.querySelector('.novo');
    const botaoExcluir = document.querySelector('.excluir');
    const campoId = document.getElementById('idCliente');

    
    function gerarNovoId() {
        return Math.floor(Math.random() * 10000) + 1; 
    }

    
    function desabilitarCampos() {
        campos.forEach(campo => campo.disabled = true);
        campoId.disabled = true; 
    }

   
    function habilitarCampos() {
        campos.forEach(campo => campo.disabled = false);
        campoId.value = gerarNovoId(); 
        campoId.disabled = true; 
        botaoNovo.disabled = true; 
    }

    
    function limparFormulario() {
        document.querySelectorAll('input[type="text"], input[type="date"], input[type="radio"], input[type="checkbox"]').forEach(campo => campo.value = '');
        document.querySelectorAll('input[type="radio"], input[type="checkbox"]').forEach(campo => campo.checked = false);
        campoId.value = ''; 
        botaoNovo.disabled = false; 
    }

    
    desabilitarCampos();

    
    botaoNovo.addEventListener('click', function () {
        habilitarCampos();
    });

    
    botaoExcluir.addEventListener('click', function () {
        limparFormulario();
        desabilitarCampos(); 
    });
});

