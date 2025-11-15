let list_nomes = [];
let i = 1;

function Determinar() {
    const input = document.getElementById("inputNome");
    const label = document.getElementById("label");
    const nome = input.value.trim();

    if (nome === "") {
        alert("Digite um nome.");
        return;
    }

    if (i <= 10) {
        list_nomes.push(nome.toLowerCase());
        i++;
        document.querySelector("h3").textContent = `Digite o nome da ${i}ª pessoa:`;
        input.value = "";

        if (i === 11) {
            document.querySelector("h3").textContent = "Digite o outro nome:";
            input.value = "";
        }
    } else {
        const encontrado = list_nomes.includes(nome.toLowerCase());
        label.innerHTML = `<p>${encontrado ? "ACHEI" : "NÃO ACHEI"}</p>`;
    }
}
