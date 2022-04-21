import React from 'react';
import {useEffect, useState} from 'react';
import {getPokemonDetails, isPokemonCached, getCachedPokemon} from './PokeDataFetcher';
import "./PokemonCard.css";

function PokemonCard({pokemon, cachedDetailsState, children}) {
    const [details, setDetails] = useState("");
    const [isFetched, setIsFetched] = useState(false);

    

    useEffect(() => {
        async function getPokemonAsync () {
            console.log('getpokemonasync 1')
            if (isPokemonCached(cachedDetailsState, pokemon.url)) {
                console.log('getpokemonasync 2')
                setDetails(getCachedPokemon(pokemon.url));
                setIsFetched(true);
            }
            else {
                console.log('getpokemonasync 3', pokemon)
                getPokemonDetails(pokemon.url).then(details => {
                    console.log(details);
                        setDetails(details);
                        setIsFetched(true);
                    }
                )
            }
        }

        getPokemonAsync();
        
    },[]);

    return ( 
        <div className='pokemon-card'>
            <h3>
                {pokemon.name}
            </h3>
            <img src={isFetched ? details.sprites.front_default : ""} alt={pokemon.name} />
            {isFetched ? details.abilities.map(element => (
                <p key={element.ability.name}>{element.ability.name}</p>
            )) : ""}
            {children}
        </div>
     );
}

export default PokemonCard;