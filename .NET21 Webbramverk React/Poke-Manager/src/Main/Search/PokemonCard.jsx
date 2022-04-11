import React from 'react';
import {useEffect, useState} from 'react';
import {getPokemonDetails, isPokemonCached, getCachedPokemon} from './PokeDataFetcher';
import "./PokemonCard.css";

function PokemonCard({pokemon}) {
    let [details, setDetails] = useState("");
    let [isFetched, setIsFetched] = useState(false);

    useEffect(() => {
        if (isPokemonCached(pokemon.url)) {
            setDetails = getCachedPokemon(pokemon.url)
            setIsFetched(true);
        } else {
            getPokemonDetails(pokemon.url).then(details => {
                setDetails(details)

                setIsFetched(true);
            });
        }

        console.log(details);
    }, []);

    return ( 
        <div className='pokemon-card'>
            <h3>
                {pokemon.name}
            </h3>
            <img src={isFetched ? details.sprites.front_default : ""} alt={pokemon.name} />
        </div>
     );
}

export default PokemonCard;