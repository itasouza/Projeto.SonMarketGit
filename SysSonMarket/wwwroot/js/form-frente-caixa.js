

var enderecoUrl = "https://localhost:44393";
var produto;

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

    //limpar formulário
    produto = undefined;
    zerarFormulario();
});