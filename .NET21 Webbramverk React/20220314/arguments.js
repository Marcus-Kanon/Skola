let a = () => {
    console.log("Test func");
};

function CoolFunction(callback)
{
    callback();
    console.log(arguments[1]);
}

CoolFunction(() => {console.log("testtest")}, 'hallåå');

