async function populatePokemonList() {
    try {
        let response = await fetch("https://pokeapi.co/api/v2/pokemon/?limit=10");
        let data = await response.json();
        
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
        console.log("Error fetching json: ", e);
    }
}

const isPokemonCached = (cachedDetailsState, url) => {
    if(cachedDetailsState.cachedDetails
        .filter(pokemon => pokemon.url == url)
        .length > 0) {
        return true;
    }
    return false;
}

const getCachedPokemon = (cachedDetailsState, url) => {
    return cachedDetailsState.cachedDetails
        .find(pokemon => pokemon.url == url)
}




export { populatePokemonList, getPokemonDetails, isPokemonCached, getCachedPokemon };