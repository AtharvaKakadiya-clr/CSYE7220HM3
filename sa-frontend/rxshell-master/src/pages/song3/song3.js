import React from 'react';
import Paper from '@material-ui/core/Paper'
import Link from '@material-ui/core/Link';
import { makeStyles } from '@material-ui/core/styles';
import Typography from '@material-ui/core/Typography';
import $ from 'jquery';
import image from '../PageNotFound/i4.jpg'

function preventDefault() {
    // const Http = new XMLHttpRequest();
    // const url = 'http://localhost:5000/SongWorld/Songworld';
    // Http.open("GET", url);
    // Http.send();

    // Http.onreadystatechange = (e) => {
    //     console.log(Http.responseText)
    // }
    $(function () {
        $('#btn-all').on('click', function () {
            console.log("getting..");
            $.get(
                'http://localhost:5000/SongWorld/Songworld3',
                function (response) {
                    
                    $("#result").html(response);
            });
           
        });
    });
}

const useStyles = makeStyles({
    depositContext: {
        flex: 1,
    },
});

export default function Song3() {
    const classes = useStyles();
    return (
        <Paper>
            
            
            <div>
                <Link color="primary" href="http://localhost:5000/SongWorld/Songworld" onClick={preventDefault}>
                    View balance
                </Link>
                
                                <div>
                <h3 >Wild Horses</h3>
                <h1>Castle of Glass </h1>
                <img src={image} alt="BigCo Inc. logo"/>
                </div>
    
    <br />
    <button id="btn-all"  onClick={preventDefault} > Lyrics</button>
    <br />
    <div id="result"></div>
            </div>
        </Paper>
    );
}
