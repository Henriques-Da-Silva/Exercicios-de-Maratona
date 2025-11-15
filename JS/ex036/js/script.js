let qtd = 0;
let contador = 0;
let funcionarios = [];

function Iniciar() {
    const inputQtd = document.getElementById("input");
    qtd = Number(inputQtd.value);

    if (qtd <= 0) {
        alert("Digite um número válido!");
        return;
    }

    document.getElementById("inputNome").disabled = false;
    document.getElementById("inputSalario").disabled = false;
    document.querySelectorAll("button")[1].disabled = false;

    inputQtd.disabled = true;
    document.querySelectorAll("button")[0].disabled = true;

    contador = 0;
    funcionarios = [];

    document.getElementById("label").innerHTML = 
        `Funcionário ${contador + 1} de ${qtd}<br>`;
}

function Submeter() {
    let nome = document.getElementById("inputNome").value.trim();
    let salario = Number(document.getElementById("inputSalario").value);

    if (!nome || salario <= 0) {
        alert("Preencha os dados corretamente!");
        return;
    }

    funcionarios.push({ nome, salario });

    contador++;

    document.getElementById("inputNome").value = "";
    document.getElementById("inputSalario").value = "";

    if (contador < qtd) {
        document.getElementById("label").innerHTML = 
            `Funcionário ${contador + 1} de ${qtd}<br>`;
        return;
    }

    finalizar();
}

function finalizar() {
    const label = document.getElementById("label");

    let salarios = funcionarios.map(f => f.salario);

    let media = salarios.reduce((a, b) => a + b) / salarios.length;
    let maior = Math.max(...salarios);
    let menor = Math.min(...salarios);

    label.innerHTML = `
        Média: ${media.toFixed(2)}<br>
        Maior: ${maior.toFixed(2)}<br>
        Menor: ${menor.toFixed(2)}<br>
    `;
}
