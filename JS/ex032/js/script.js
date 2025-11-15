const label = document.getElementById("label");

let totalGraos = 1;

for (let i = 1; i < 64; i++) {
    totalGraos += 2*totalGraos;
}

label.innerHTML = `
    <h3>Total de grãos recebidos:</h3>
    <p>${totalGraos}</p>`