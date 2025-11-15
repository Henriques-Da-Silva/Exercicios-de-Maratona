 function Somar(){
    let numeros = document.getElementById('input').value
    const lista_numeros = numeros.split('')
    let soma = 0

    for (numero of lista_numeros){
        soma += Number(numero)
    }

    document.getElementById('label').innerHTML = `<p>Resultado: ${soma} </p>`
}