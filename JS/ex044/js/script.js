function Calcular() {
    const n1 = parseInt(document.getElementById('num1').value)
    const n2 = parseInt(document.getElementById('num2').value)
    const label = document.getElementById('label')

    if (isNaN(n1) || isNaN(n2) || n1 < 0 || n2 <= 0) {
        label.innerHTML = `<span style="color:red">Digite apenas inteiros positivos (e N2 não pode ser zero).</span>`
        return }

    let quociente = 0
    let resto = n1

    while (resto >= n2) {
        resto = resto - n2
        quociente++
    }

    label.innerHTML = `<p>Quociente: <strong>${quociente}</strong></p><p>Resto: <strong>${resto}</strong></p>`
}
