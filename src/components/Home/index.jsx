import { Card } from "../Card";
import React from 'react';
import axios from 'axios';


export default class Home extends React.Component {
    state = {
        computers: []
    }

    componentDidMount() {
        axios.get('https://localhost:44323/api/computers')
        .then(res => {
            const computers = res.data;
            this.setState({ computers });
            console.log(computers);
          })
        .catch(err => {
            console.log(err);
        })
    }

    render() {
        return (
            <div className="row">
                {
                    this.state.computers.map(c => <Card card = {c} key={c.id}></Card>)
                }
            </div>
    )
    }
}

