function Calcular(){
    let num1 = document.getElementById('num1').value
    let num2 = document.getElementById('num2').value
    let num3 = document.getElementById('num3').value

    if (num1 !== '' && num2 !== '' && num3 !== ''){
        a = Number(num1)
        b = Number(num2)
        c = Number(num3)

        const lista = [a, b, c]
        lista.sort((a, b) => b - a)

        document.getElementById('label').innerHTML = `<p>Maior: ${lista[0]} <br> Intermediário: ${lista[1]} <br> Menor: ${lista[2]} </p>`

    } else{alert('Preencha todos os Campos.')}
}