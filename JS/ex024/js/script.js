const label = document.getElementById("label");
let soma = 0;

for (let i = 1; i <= 500; i++) {
    if (i % 2 !== 0 && i % 3 === 0) {
        soma += i;
    }
}

label.innerHTML = `<h2>Soma: ${soma}</h2>`;
