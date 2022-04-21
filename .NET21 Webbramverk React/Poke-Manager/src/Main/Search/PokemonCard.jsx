import React from 'react';
import {useEffect, useState} from 'react';
import {getPokemonDetails, isPokemonCached, getCachedPokemon} from './PokeDataFetcher';
import {team, addTeamMember} from '../TeamData';
import "./PokemonCard.css";

function PokemonCard(props) {
    const pokemon = props.pokemon;
    const [details, setDetails] = useState("");
    const [isFetched, setIsFetched] = useState(false);

    useEffect(() => {
        if (isPokemonCached(pokemon.url)) {
            setDetails(getCachedPokemon(pokemon.url));
            setIsFetched(true);
        }
        else {
            let abilities = [];
            getPokemonDetails(pokemon.url).then(details => {
                getPokemonDetails(details.abilities.map(element => {
                    getPokemonDetails(element.ability.url).then(ability => {
                        element={...element, ability};
                    });

                    details.abilities.map(element => {
                        element.ability.)
                }

            
            setDetails(details.ab)
            setIsFetched(true);
            });
        }
    }, []);

    return ( 
        <div className='pokemon-card'>
            <h3>
                {pokemon.name}
            </h3>
            <img src={isFetched ? details.sprites.front_default : ""} alt={pokemon.name} />
            {isFetched ? details.abilities.map(element => (
                <p key={element.ability.name}>{element.ability.name}</p>
            )) : ""}
            {props.children}
        </div>
     );
}

export default PokemonCard;