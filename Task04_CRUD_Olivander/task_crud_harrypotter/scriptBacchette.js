//function per stampare le casate
function stampaBacchetta() {
    let elencoBacchette = JSON.parse(localStorage.getItem("bacchette"))
    let cardBacchetta = ""
    
    elencoBacchette.forEach((bacchetta,index) => cardBacchetta += 
                            `<div class="card col-3 px-1" style="width: 14rem;">
                                <img src="${bacchetta.fotoBacchetta}" class="card-img-top" style="width: 7rem; height: 7rem" alt="foto-bacchetta">
                                <div class="card-body"  style="height: 8rem;> 
                                    <h6 class="card-title">Bacchetta di ${bacchetta.materiale}</h6>
                                    <p class="card-text">Nucleo in ${bacchetta.nucleo}</p>
                                </div>
                                <ul class="list-group list-group-flush">
                                    <li class="list-group-item font-weight-light">Lunghezza: ${bacchetta.lunghezza}</li>
                                    <li class="list-group-item font-weight-light">Resistenza: ${bacchetta.resistenza}</li>
                                    <li class="list-group-item font-weight-light">Nome mago: ${bacchetta.mago}</li>
                                </ul>
                                <div class="card-body mt-0 text-center mx-auto"  style="height: 6rem;>
                                    <p class="font-weight-bold">${bacchetta.casata}</p>
                                    <div class="row mt-0 text-center mx-auto">

                                        <button class="btn btn-warning" onclick="modificaBacchetta(${index+1})"> <i class="bi bi-pencil-square"></i> </button>
                                        <button class="btn btn-danger" id="btnDeleteBacchetta data-identif="" onclick="eliminaBacchetta(${index+1})" > <i class="bi bi-trash3-fill"></i> </button>
                                    </div>
                                </div>
                            </div>
                            `)
                        
    document.querySelector("#rigaBacchette").innerHTML = cardBacchetta
}

stampaBacchetta()

function modificaBacchetta(index){
    $("#modalModBacchetta").modal('show');

    let elencoBacchette = localStorage.getItem("bacchette") != null ?
        JSON.parse(localStorage.getItem("bacchette")) : [];

    for(let [idx, item] of elencoBacchette.entries()){
        if(index == idx){
            document.querySelector("#input-materiale-mod").value = item.materiale
            document.querySelector("#input-nucleo-mod").value = item.nucleo
            //select menu
            document.querySelector("#input-resistenza-mod").value = item.resistenza
            document.querySelector("#input-lunghezza-mod").value = item.lunghezza
            document.querySelector("#input-mago-mod").value = item.mago
            document.querySelector("#input-casata-mod").value = item.casata
            document.querySelector("#input-linkBacc-mod").value = item.fotoBacchetta
            
        }
    }
}

function eliminaBacchetta(index){
    //console.log(codiceBacchetta)
    let elencoBacchette = localStorage.getItem("bacchette") != null ?
        JSON.parse(localStorage.getItem("bacchette")) : [];

        elencoBacchette.splice(index,1)
        
        localStorage.setItem("bacchette", JSON.stringify(elencoBacchette))
        stampaBacchetta()
    // $("#btn-salva").data('identif', indice);
}

