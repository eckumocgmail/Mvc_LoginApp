const connection = new signalR.HubConnectionBuilder()
    .withUrl("/hubs/client")
    .configureLogging(signalR.LogLevel.Information)
    .build();

var interval;
async function start() {
    try {
        await connection.start();
        interval = setInterval(() => {
            connection.invoke('OnTimeUpdate');

        }, 100);
    } catch (err) {
        console.log(err);
        setTimeout(start, 5000);
    }
};

connection.onclose(async () => {
    clearInterval(interval);
    await start();
});

// Start the connection.
start();