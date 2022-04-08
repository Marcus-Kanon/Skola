const nodes = [];

function addToRegister(nodeId) {
		nodes.push(nodeId);
		console.log(nodeId);
}

function goThroughRegister(func) {
    for(const node in nodes) {
        func(node);
    }
}

export {nodes, addToRegister};
