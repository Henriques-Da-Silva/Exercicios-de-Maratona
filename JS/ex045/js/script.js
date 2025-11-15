function Calcular(){
    let num1 = document.getElementById('num1').value
    let num2 = document.getElementById('num2').value
    const operador = document.getElementById('operador').value

    if (num1 !== '' && num2 !== ''){
        num1 = Number(num1)
        num2 = Number(num2)

        if (operador == 'soma'){
            document.getElementById('label').innerHTML = `Resultado = ${num1+num2}`
        } else if (operador == 'subt'){
            document.getElementById('label').innerHTML = `Resultado = ${num1-num2}`
        } else if (operador == 'multi'){
            document.getElementById('label').innerHTML = `Resultado = ${num1*num2}`
        } else if (operador == 'divi'){
            if (num2 == 0){alert('Erro: Divisão por zero!')}
            else{
            document.getElementById('label').innerHTML = `Resultado = ${num1/num2}`
            }
        }
    } else{alert('Preencha todos os Campos.')}
}