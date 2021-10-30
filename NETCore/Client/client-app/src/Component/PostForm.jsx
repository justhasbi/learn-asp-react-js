import React, { useState } from 'react';

function PostForm() {
    const [formData, setFormData] = useState({
        NIK: "",
        FirstName: "",
        LastName: "",
        Phone: "",
        BirthDate: "",
        Salary: 0,
        Email: "",
        gender: 0
    })

    const handleSubmit = (e) => {
        e.preventDefault()
        fetch("https://localhost:44370/api/persons", {
            method: "POST",
            body: JSON.stringify(formData),
            headers: {
                "Content-type": "application/json; charset=UTF-8"
            }
        }).then(res => console.log("Success")).catch(err => console.log(`Failed:  ${err.message}`))
    }

    return (
        <>
            <form onSubmit={ handleSubmit }>
                <input type="text" id="NIK" name="NIK" placeholder="NIK" onChange={(e) => setFormData({ ...formData, NIK: e.target.value })} />
                <input type="text" id="FirstName" name="FirstName" placeholder="FirstName" onChange={(e) => setFormData({ ...formData, FirstName: e.target.value })} />
                <input type="text" id="LastName" name="LastName" placeholder="LastName" onChange={(e) => setFormData({ ...formData, LastName: e.target.value })} />
                <input type="text" id="Email" name="Email" placeholder="Email" onChange={(e) => setFormData({ ...formData, Email: e.target.value })} />
                <input type="text" id="Phone" name="Phone" placeholder="Phone" onChange={(e) => setFormData({ ...formData, Phone: e.target.value })} />
                <input type="date" id="BirthDate" name="BirthDate" placeholder="BirthDate" onChange={(e) => setFormData({ ...formData, BirthDate: e.target.value })} />
                <input type="number" id="Salary" name="Salary" placeholder="Salary" onChange={(e) => setFormData({ ...formData, Salary: parseInt(e.target.value) })} />
                <input type="number" id="gender" name="gender" placeholder="gender" onChange={(e) => setFormData({ ...formData, gender: parseInt(e.target.value) })} />

                <button type="submit" id="submit" name="submit">Submit</button>
            </form>
        </>
        );
}

export default PostForm;