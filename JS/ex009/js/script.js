var inicio = 0
var numero = 0
let text = document.getElementById('text')

text.textContent = 'Espere...'

const tempo_aleatorio = Math.floor(Math.random() * 4000) + 2000

setTimeout(() => {
    numero = Math.floor(Math.random() * 10) + 1
    text.textContent = `Agora! Número: ${numero}`
    inicio = new Date().getSeconds()
}, tempo_aleatorio)

function Calcular(){
    let number = document.getElementById('input').value
    let tempo = (new Date().getSeconds()) - inicio
   
    if (numero === Number(number)){
        document.getElementById('label').innerHTML = `<p>Acertou o número🥳<br> Tempo: ${tempo} segundos</p>`
    } else{
        document.getElementById('label').innerHTML = `<p>Número Errado!</p>`
    }
}