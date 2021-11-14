const graph = {
    A: ['C','B'],
    B: ['A','D'],
    C: ['D','E'],
    D: ['B'],
    E: []
};
const startingNode = 'A';
const visited = new Set();

function visitBFS(graph, node){
    const queue = [node];
    while(queue.length > 0){
        const currentNode = queue.shift();
        if(visited.has(currentNode)){
            continue;
        }
        visited.add(currentNode);
        console.log(currentNode);
        for(let neighbor of graph[currentNode]){
            queue.push(neighbor);
        }
    }
}
visitBFS(graph, startingNode);