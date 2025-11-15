function Determinar() {
    const nome1 = document.getElementById('Nome1').value
    const peso1 = parseFloat(document.getElementById('Peso1').value)
    const altura1 = parseFloat(document.getElementById('Altura1').value)

    const nome2 = document.getElementById('Nome2').value
    const peso2 = parseFloat(document.getElementById('Peso2').value)
    const altura2 = parseFloat(document.getElementById('Altura2').value)

    const resultado = document.getElementById('label')

    if (!nome1 || !nome2 || isNaN(peso1) || isNaN(peso2) || isNaN(altura1) || isNaN(altura2)) {
        resultado.innerHTML = `<span style="color:red;">Preencha todos os campos corretamente.</span>`
        return
    }

    let pessoaMaisPesada = ""
    let maiorPeso = 0

    if (peso1 > peso2) {
        pessoaMaisPesada = nome1
        maiorPeso = peso1
    } else {
        pessoaMaisPesada = nome2
        maiorPeso = peso2
    }

    let pessoaMaisAlta = ""
    let maiorAltura = 0

    if (altura1 > altura2) {
        pessoaMaisAlta = nome1
        maiorAltura = altura1
    } else {
        pessoaMaisAlta = nome2
        maiorAltura = altura2
    }

    resultado.innerHTML = `<p><strong>Mais pesado(a):</strong> ${pessoaMaisPesada} — ${maiorPeso} kg</p><p><strong>Mais alto(a):</strong> ${pessoaMaisAlta} — ${maiorAltura} m</p>`
}