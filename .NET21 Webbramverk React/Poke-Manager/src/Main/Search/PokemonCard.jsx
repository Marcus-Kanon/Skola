import React from 'react';
import {useEffect, useState} from 'react';
import EditableText from '../EditableText/EditableText';
import {isInputNotEmpty, isInputOnlyCharacters, isInputOnlyNumbers} from '../EditableText/validInputCheckers.js';
import {getPokemonDetails, isPokemonCached, getCachedPokemon} from './PokeDataFetcher';
import "./PokemonCard.css";

function PokemonCard({pokemon, cachedDetailsState, onValidNameChange, children}) {
    const [details, setDetails] = useState("");
    const [isFetched, setIsFetched] = useState(false);


    useEffect(() => {
        async function getPokemonAsync () {
            if (isPokemonCached(cachedDetailsState, pokemon.url)) {
                setDetails(getCachedPokemon(pokemon.url));
                setIsFetched(true);
            }
            else {
                getPokemonDetails(pokemon.url).then(details => {
                        setDetails(details);
                        setIsFetched(true);
                    }
                )
            }
        }

        getPokemonAsync();
        
    },[]);

    function inputHandler(input, key) {
        onValidNameChange(input, key);
        console.log("KEY: ", key);
    }

    return ( 
        <div className='pokemon-card'>
            {onValidNameChange ? <EditableText id={pokemon.key} label={pokemon.name} validation={{isInputNotEmpty, isInputOnlyCharacters}} handler={inputHandler}/> : (<p className='pokemon-name'>{pokemon.name}</p>)}
            <img src={isFetched ? details.sprites.front_default : ""} alt={pokemon.name} />
            <div className='abilities'>
                Abilities:
                {isFetched ? details.abilities.map(element => (
                    <p key={element.ability.name}>{element.ability.name}</p>
                    
                )) : ""}
            </div>


            {children}
        </div>
     );
}

export default PokemonCard;