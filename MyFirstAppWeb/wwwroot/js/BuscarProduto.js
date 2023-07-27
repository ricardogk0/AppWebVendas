$(document).ready(function () {

    function calcularTotal(tr) {
        var quantidade = parseFloat(tr.find('.quantidade-input').val());
        var preco = parseFloat(tr.find('.preco-input').val());
        var total = quantidade * preco;
        tr.find('.total-input').val(total.toFixed(2));
    }

    $('.vendedor-input').on('blur', function () {
        var codigo = $(this).val();
        var tr = $(this).closest('tr');

        $.ajax({
            url: '/Vendas/BuscarVendedor?vendedor=' + codigo,
            method: 'GET',
            dataType: 'json',
            success: function (response) {
                if (response) {
                    tr.find('.vendedor-input').val(response.nome);
                } else {
                    alert('Vendedor não encontrado. Verifique o código informado.');
                }
            },
            error: function () {
                alert('Erro ao buscar o vendedor. Tente novamente mais tarde.');
            }
        });
    });

    $('.cliente-input').on('blur', function () {
        var codigo = $(this).val();
        var tr = $(this).closest('tr');

        $.ajax({
            url: '/Vendas/BuscarCliente?cliente=' + codigo,
            method: 'GET',
            dataType: 'json',
            success: function (response) {
                if (response) {
                    tr.find('.cliente-input').val(response.nome);
                } else {
                    alert('Cliente não encontrado. Verifique o código informado.');
                }
            },
            error: function () {
                alert('Erro ao buscar o cliente. Tente novamente mais tarde.');
            }
        });
    });

    $('.produto-input').on('blur', function () {
        var codigo = $(this).val();
        var tr = $(this).closest('tr');

        $.ajax({
            url: '/Vendas/BuscarProduto?produto=' + codigo,
            method: 'GET',
            dataType: 'json',
            success: function (response) {
                if (response) {
                    tr.find('.produto-input').val(response.item);
                    tr.find('.preco-input').val(response.preco);
                } else {
                    alert('Produto não encontrado. Verifique o código informado.');
                }
            },
            error: function () {
                alert('Erro ao buscar o produto. Tente novamente mais tarde.');
            }
        });
    });

    $('.quantidade-input').on('input', function () {
        var tr = $(this).closest('tr');
        calcularTotal(tr);
    });

    $(document).ready(function () {
        // Manipulador de evento para o clique do botão de lupa
        $("#btnPesquisarVendedores").on("click", function () {
            $.ajax({
                url: "/Vendas/PesquisarVendedores",
                type: "GET",
                dataType: "json",
                success: function (data) {
                    // Montar a lista de vendedores e exibir no local adequado
                    var listaVendedores = "<ul>";
                    $.each(data, function (index, vendedor) {
                        listaVendedores += "<li>" + vendedor.Nome + "</li>";
                    });
                    listaVendedores += "</ul>";
                    $("#listaVendedores").html(listaVendedores);
                },
                error: function () {
                    alert("Ocorreu um erro ao buscar os vendedores.");
                }
            });
        });
    });
});
