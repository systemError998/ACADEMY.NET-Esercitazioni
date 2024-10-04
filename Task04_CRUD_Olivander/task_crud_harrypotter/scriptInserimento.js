//function per aggiungere bacchetta
function aggiungiBacchetta() {
    // $("#aggiungiCasata").modal('show');

    let elencoBacchette = localStorage.getItem("bacchette") != null ?
        JSON.parse(localStorage.getItem("bacchette")) : [];


    //input
    //let varCodice = document.querySelector("#input-codice").value
    let varMateriale = document.querySelector("#input-materiale").value
    let varNucleo = document.querySelector("#input-nucleo").value
    //select menu
    let varResi = document.querySelector("#input-resistenza").value
    let varLung = document.querySelector("#input-lunghezza").value
    let varMago = document.querySelector("#input-mago").value
    let varCasata = document.querySelector("#input-casata").value
    let varLinkBacc = document.querySelector("#input-linkBacc").value

    console.log(varCasata)

    let bacchetta = {
        //codice: varCodice,
        materiale: varMateriale,
        nucleo: varNucleo,
        resistenza: varResi,
        lunghezza: varLung,
        mago: varMago,
        casata: varCasata,
        fotoBacchetta: varLinkBacc,
    }
    elencoBacchette.push(bacchetta)

    //document.querySelector("#input-codice").value = ""
    document.querySelector("#input-materiale").value = ""
    document.querySelector("#input-nucleo").value = ""
    document.querySelector("#input-resistenza").value = ""
    document.querySelector("#input-lunghezza").value = ""
    document.querySelector("#input-mago").value = ""
    document.querySelector("#input-casata").value = ""
    document.querySelector("#input-linkBacc").value = ""
    

    localStorage.setItem("bacchette", JSON.stringify(elencoBacchette))

    $("#aggiungiBacchetta").modal('hide');

    stampaBacchetta()
    location.href = "bacchette.html"
}


//gattonero, pescerosso, brucoverde, canedoro
//function per aggiungere casata
function aggiungiCasata() {
    // $("#aggiungiCasata").modal('show');

    let elencoCasate = localStorage.getItem("casate") != null ?
        JSON.parse(localStorage.getItem("casate")) : [];


    //input
    let varNome = document.querySelector("#input-nome").value
    let varDesc = document.querySelector("#input-desc").value
    let varLogo = document.querySelector("#input-logo").value

    let casata = {
        nome: varNome,
        desc: varDesc,
        logo: varLogo
    }

    elencoCasate.push(casata)

    document.querySelector("#input-nome").value = ""
    document.querySelector("#input-desc").value = ""
    document.querySelector("#input-logo").value = ""

    localStorage.setItem("casate", JSON.stringify(elencoCasate))

    $("#aggiungiCasata").modal('hide');

    stampaCasata()
    location.href = "casate.html"
}

function elencoCasate(){
    let elencoCasate = localStorage.getItem("casate") != null ?
        JSON.parse(localStorage.getItem("casate")) : [];

    return elencoCasate;
}

function generaCasata(){
    elencoCasate = elencoCasate();
    var randomIndex = Math.floor(Math.random() * elencoCasate.length); 
    var randomElement = elencoCasate[randomIndex];

    // console.log(randomElement)
    let casataGenerata = document.querySelector("#input-casata")
    casataGenerata.innerHTML = randomElement.nome
    
}