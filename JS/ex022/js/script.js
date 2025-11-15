let i = 1;
let listaNumeros = [];

function Determinar() {
    const input = document.getElementById("inputNumero");
    const label = document.getElementById("label");
    const titulo = document.getElementById("titulo");
    const valor = input.value.trim();

    if (valor === "") {
        alert("Preencha o campo.");
        return;
    }

    const numero = parseInt(valor);
    i++;

    if (i <= 20) {
        listaNumeros.push(numero);
        titulo.textContent = `Digite o ${i}º número:`;
        input.value = "";
    } else {
        listaNumeros.push(numero);
        const maior = Math.max(...listaNumeros);
        const posicao = listaNumeros.indexOf(maior) + 1;

        label.innerHTML = `
            <p>O maior valor digitado foi: <strong>${maior}</strong></p>
            <p>Posição: <strong>${posicao}º</strong></p>
        `;
    }
}
