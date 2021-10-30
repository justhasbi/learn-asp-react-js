import React, { useState } from 'react';
import { useEffect } from 'react';
import Card from './Card';

function CardContainer() {
    const [data, setData] = useState([]); // hooks

    useEffect(() => { // hooks
        const fetchData = async () => {
            const result = await fetch('https://localhost:44370/api/persons').then(res => res.json())
            setData(result.data)
        }

        fetchData();

    }, []);

    console.log(data);
    return (
        <div className="card-container">
            {data.map(item =>
                <Card key={ item.nik } dataProps={ item } />
                )}
        </div>
    );
}

export default CardContainer;