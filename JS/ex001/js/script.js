function Calcular(){
    let tempo_segundos = Number(document.getElementById('input').value)
    let horas = 0
    let minutos = 0
    let label = document.getElementById('label')

    if (tempo_segundos >= 3600){
        horas = Math.floor(tempo_segundos/3600)
        tempo_segundos -= (horas*3600)
    }
    if (tempo_segundos >= 60){
        minutos = Math.floor(tempo_segundos/60)
        tempo_segundos -= (minutos*60)
    }

    let text = `${horas} Horas <br> ${minutos} Minutos <br> ${tempo_segundos} Segundos`

    label.innerHTML = text
}