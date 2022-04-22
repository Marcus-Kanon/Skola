import React from 'react';
import {useState, useEffect} from 'react';
import {removeTeamMember} from './TeamData.js';
import PokemonCard from './Search/PokemonCard.jsx';
import './Search/PokemonCard.css';
import './Team.css';

function Team({teamState, cachedDetailsState}) {

    function onValidNameChange(input, key) {
        let team = teamState.team.map(member => {
            console.log("Key: ", key, "Name: ", member.name);
            if(member.key == key) {
                member.name = input;
                console.log("Member with right key: ", member.name);
            }
        })
        console.log("Team: ", team);
    }

    return (
            <div>
                <h1>Team</h1>
                <div className='pokemon-card-container'>
                { teamState.team.length > 0 ? teamState.team.map(member => (
                    <PokemonCard onValidNameChange={onValidNameChange} id={member.key} key={member.key} pokemon={member} cachedDetailsState={cachedDetailsState}>
                        <a onClick={() => {removeTeamMember(teamState, member);}}>Remove from team</a>
                    </PokemonCard>
                    )) : <h2>Här var det tomt</h2>}
                </div>
            </div>
     );
}

export default Team;