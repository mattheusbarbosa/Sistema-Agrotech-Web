


function gerarArquivoExcel() {
    
    const linhasTabela = document.querySelectorAll('#tabela-body tr');

   
    if (linhasTabela.length === 0) {
        alert("Não há dados para gerar o relatório.");
        return;
    }

   
    const dadosExcel = [["ID", "Tipo de Produto", "Quantidade Entrada", "Quantidade Saída", "Estoque"]];

   
    linhasTabela.forEach(linha => {
        const colunas = linha.querySelectorAll('td');
        const linhaDados = Array.from(colunas).map(coluna => coluna.textContent.trim()); 
        dadosExcel.push(linhaDados); 
    });

    
    const workbook = XLSX.utils.book_new(); 
    const worksheet = XLSX.utils.aoa_to_sheet(dadosExcel); 

    
    XLSX.utils.book_append_sheet(workbook, worksheet, "Relatório Estoque");

   
    XLSX.writeFile(workbook, `relatorio_estoque_${obterDataAtual()}.xlsx`);

    alert("Relatório Excel gerado com sucesso!");
}


function obterDataAtual() {
    const data = new Date();
    return `${data.getFullYear()}-${String(data.getMonth() + 1).padStart(2, '0')}-${String(data.getDate()).padStart(2, '0')}`;
}


document.getElementById('salvar').addEventListener('click', gerarArquivoExcel);
