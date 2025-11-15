function Montar(){
    let num = Number(document.getElementById("inputNum").value);
    let label = document.getElementById("label");
    label.innerHTML = `<h2></h2>`;
    for(let i = 1; i <= 13; i++){
        let resultado = num * i;
        label.innerHTML += `<p>${num} x ${i} = ${resultado}</p>`;
    }

}