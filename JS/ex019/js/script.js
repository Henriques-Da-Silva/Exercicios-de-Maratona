function Determinar() {
    const input = document.getElementById("input").value.trim();
    const label = document.getElementById("label");
    label.innerHTML = "";

    const vogais = ['a', 'e', 'i', 'o', 'u'];
    const digitos = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    let n_vogais = 0;
    let n_digitos = 0;

    if (input === "") {
        alert("Digite a palavra.");
        return;
    }

    const texto = input;
    const textoInvertido = texto.split("").reverse().join("");

    let resultado = "";
    resultado += `A palavra contém ${texto.length} caracteres.<br>`;
    resultado += `Palavra em maiúscula: ${texto.toUpperCase()}<br>`;

    for (let char of texto.toLowerCase()) {
        if (vogais.includes(char)) n_vogais++;
        if (digitos.includes(char)) n_digitos++;
    }

    resultado += `A palavra contém: ${n_vogais} vogais.<br>`;

    if (texto.toLowerCase().startsWith("uni")) {
        resultado += "A palavra começa com UNI.<br>";
    }

    if (texto.toLowerCase().endsWith("rio")) {
        resultado += "A palavra termina com RIO.<br>";
    }

    resultado += `A palavra contém: ${n_digitos} dígitos.<br>`;

    if (texto.toLowerCase() === textoInvertido.toLowerCase()) {
        resultado += "A palavra é palíndromo.<br>";
    }

    label.innerHTML = resultado;
}
