import axios from 'axios'

export default axios.create({
    baseURL : document.getElementsByTagName('base')[0].getAttribute('href')
});