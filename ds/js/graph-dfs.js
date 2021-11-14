const graph = {
    A: ['C','B'],
    B: ['A','D'],
    C: ['D','E'],
    D: ['B'],
    E: []
};
const startingNode = 'A';
const visited = new Set();

function visitDFS(graph, node){
    if(visited.has(node)){
        return;
    }
    visited.add(node);
    console.log(node);
    for(let neighbor of graph[node]){
        visitDFS(graph, neighbor);
    }
}
visitDFS(graph, startingNode);
