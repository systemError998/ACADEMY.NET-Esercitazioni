//function per stampare le casate
function stampaCasata() {
    let elencoCasate = JSON.parse(localStorage.getItem("casate"))
    let rigaCasata = ""

    elencoCasate.forEach(casata => rigaCasata +=
                                        (`
                                            <tr>
                                                <th scope="row">1</th>
                                                <td><img src="${casata.logo}"  alt="..." height="50px"></td>
                                                <td>${casata.nome}</td>
                                                <td>${casata.desc}</td>
                                                <td>num bacchette</td>
                                                <td>
                                                    <button class="btn btn-warning"><i class="bi bi-pencil-square"></i></button>
                                                    <button class="btn btn-danger"><i class="bi bi-trash3-fill"></i></button>
                                                </td>
                                            </tr>
                                        `))

    document.querySelector("#tabellaCasate").innerHTML = rigaCasata
}





stampaCasata()


// function modificaCasata{}