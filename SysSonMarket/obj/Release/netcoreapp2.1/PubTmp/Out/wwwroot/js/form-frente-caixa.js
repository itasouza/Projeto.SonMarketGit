

var enderecoUrl = "https://localhost:44393";
var produto;
var compra = [];

function preencherFormulario(dadosProduto) {
    $("#campoNomeProduto").html(dadosProduto.nome);
    $("#campoNomeCategoria").html(dadosProduto.categoria.nome);
    $("#CampoNomeFornecedor").html(dadosProduto.fornecedor.nome);
    $("#CampoPreco").html(dadosProduto.precoDeVenda);
}


function zerarFormulario() {
    $("#campoNomeProduto").html("...");
    $("#campoNomeCategoria").html("...");
    $("#CampoNomeFornecedor").html("...");
    $("#CampoPreco").html("...");
    $("#quantidade").val("");
    $("#codProduto").val("");
}

function adicionarNaTabela(p, qtd) {

    var produtoTemp = {};
    Object.assign(produtoTemp, produto);
    compra.push(produtoTemp);

    $("#compras").append(` <tr> 
            <td>${p.nome}</td>
            <td>${qtd}</td>
            <td>R$ ${p.precoDeVenda}</td>
            <td>R$ ${p.precoDeVenda * qtd}</td>
            <td>
               <a class='btn btn-danger' data-toggle='tooltip' data-placement='top' title='Deletar' href='#'><i class='fas fa-trash-alt'></i> </a>
            </td>
    </tr>`);
 }


/*ajax*/
$("#pesquisar").click(function () {

    var codigoProduto = $("#codProduto").val();
    var enderecoCompleto = enderecoUrl + "/produto/RetornarProdutoTelaVenda/" + codigoProduto;

    $.post(enderecoCompleto, function (dados, status) {
        console.log(dados);
        produto = dados;
        preencherFormulario(produto);
    }).fail(function () {
        alert("Produto inválido");
    });

});


$("#produtoForm").on("submit", function (event) {
    event.preventDefault();
    var produtoParaTabela = produto;
    var QuantidadeProduto = $("#quantidade").val();
    if (QuantidadeProduto < 1) {
        QuantidadeProduto = 1;
    }
    

    console.log(produtoParaTabela);
    console.log(QuantidadeProduto);
    adicionarNaTabela(produtoParaTabela, QuantidadeProduto);

    //limpar formulário
    //produto = undefined;
    zerarFormulario();
});