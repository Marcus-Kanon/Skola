const addTeamMember = (teamState, member) => {
    if(teamState.team.length < 5) {
        teamState.set(team=>[...team, {...member, key: team[0] ? team[team.length-1].key+1 : 0}]);
    }
}

const removeTeamMember = (teamState, member) => {
    teamState.team.length > 0 ? teamState.set(teamState.team.filter(pokemon => pokemon.key != member.key)) : teamState.set(member);
}

export {addTeamMember, removeTeamMember};
