/**
 * Wraps the calls to the ContentDeliveryAPI. It's used by the vuex
 */

import axios from 'axios';

const get = (baseURL, url, parameters, headers) => {
    return axios({
        method: 'get',
        baseURL: baseURL,
        url: url,
        params: parameters,
        headers: Object.assign({}, headers)
    });
};

export default {
    /**
     * Getting content with the content link is the default way of calling the ContentDeliveryAPI.
     */
    getContentByContentLink: (contentLink, parameters) =>
        get('api/episerver/v3/', `content/${contentLink}`, parameters),

    /**
     * Getting data from ContentDeliveryAPI through regular routing (friendly URLs) was added in ContentDeliveryAPI 2.3.0.
     */
    getContentByFriendlyUrl: (friendlyUrl, parameters) =>
        get('/', friendlyUrl, parameters, { Accept: 'application/json'}),
};
