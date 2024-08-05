import { useEffect, useState } from 'react';
import { HubConnectionBuilder, LogLevel } from '@microsoft/signalr';
import ChatCard from './components/ChatCard';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

function App() {
    const [input, setInput] = useState('');
    const [output, setOutput] = useState('');
    const [connection, setConnection] = useState(null);

    useEffect(() => {
        const newConnection = new HubConnectionBuilder()
            .withUrl(process.env.REACT_APP_SIGNALR_URL)
            .configureLogging(LogLevel.Information)
            .build();

        setConnection(newConnection);

        return () => {
            newConnection.stop();
        };
    }, []);

    useEffect(() => {
        if (connection) {
            connection.start()
                .then(() => {
                    console.log('Connected to SignalR hub');

                    connection.on('ReceiveMessage', (source, message) => {
                        if (source !== 'React') {
                            setOutput(message);
                        }
                    });
                })
                .catch(err => console.error('Error connecting to SignalR hub', err));
        }
    }, [connection]);

    const sendMessage = async (message) => {
        if (connection) {
            try {
                await connection.invoke('SendMessage', 'React', message);
            } catch (err) {
                console.error('Error sending message', err);
            }
        }
    };

    const handleChange = (e) => {
        const message = e.target.value;
        setInput(message);
        sendMessage(message);
    };

    return (
        <div className="container mt-5">
            <div className="row">
                <div className="col-md-6 offset-md-3">
                    <ChatCard 
                        inputValue={input} 
                        outputMessage={output} 
                        handleInputChange={handleChange} 
                    />
                </div>
            </div>
        </div>
    );
}

export default App;
