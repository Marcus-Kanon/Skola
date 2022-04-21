
let pokeCache = [];

async function populatePokemonList() {
    try {
        let response = await fetch("https://pokeapi.co/api/v2/pokemon/?limit=200");
        data = await response.json();
        console.log("Data: ", data);
        return data
    }
    catch (e) {
        console.log(e);
        return null
    }
}

async function getPokemonDetails(url) {
    try {
        let response = await fetch(url);
        let pokemon = await response.json();
        return pokemon;
    }
    catch (e){
        console.log(e);
    }
}

const isPokemonCached = (url) => {
    if(pokeCache
        .filter(pokemon => pokemon.url == url)
        .length > 0) {
        return true;
    }
    return false;
}

const getCachedPokemon = (url) => {
    return pokeCache
        .find(pokemon => pokemon.url == url)
}




export { data, populatePokemonList, getPokemonDetails, isPokemonCached, getCachedPokemon };