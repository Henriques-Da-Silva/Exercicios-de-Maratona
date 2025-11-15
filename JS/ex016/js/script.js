let popA = 80000;
let popB = 200000;
const taxaA = 0.03;
const taxaB = 0.015;
let anos = 0;

while (popA < popB) {
    popA += popA * taxaA;
    popB += popB * taxaB;
    anos++;
}

const texto = document.getElementById("texto");
texto.innerHTML += `<strong>${anos}</strong>`;