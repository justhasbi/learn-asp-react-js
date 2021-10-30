import React from 'react';
import './cards.css'

function Card({ dataProps }) {
    return (
        <>
            <div className="card">
                <h4>{`${dataProps.firstName} ${dataProps.lastName}`}</h4>
                <ul>
                    <li>{dataProps.birthDate}</li>
                    <li>{dataProps.email}</li>
                    <li>{dataProps.gender === 0 ? "Male" : "Female"}</li>
                    <li>{dataProps.phone}</li>
                    <li>{dataProps.salary}</li>
                </ul>
            </div>
        </>
        );
}

export default Card;