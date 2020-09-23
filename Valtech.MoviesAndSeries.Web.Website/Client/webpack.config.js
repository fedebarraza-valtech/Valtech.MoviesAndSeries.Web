const path = require('path'),
    webpack = require('webpack');

const { VueLoaderPlugin } = require('vue-loader');
const MiniCSSExtractPlugin = require('mini-css-extract-plugin');

const config = {
    mode: 'development',
    entry: {
        main: './main.js'
    },
    output: {
        // eslint-disable-next-line no-undef
        path: path.resolve(__dirname, '../Static/'),
        filename: 'js/[name].min.js',
    },
    plugins: [
        new webpack.ProgressPlugin(),
        new VueLoaderPlugin(),
        new MiniCSSExtractPlugin({
            filename: 'css/[name].css',
        }),
    ],
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: [/node_modules/],
                use: [{
                    loader: 'babel-loader'
                }]
            },
            {
                test: /\.vue$/,
                exclude: [/node_modules/],
                loader: 'vue-loader'
            },
            {
                test: /\.(js|vue)$/,
                exclude: /node_modules/,
                loader: 'eslint-loader',
                options: {
                    configFile: '.eslintrc.js'
                }
            },
            {
                test: /\.css$/,
                use: [
                    MiniCSSExtractPlugin.loader,
                    { loader: 'css-loader', options: { sourceMap: true } },
                ]
            },
            {
                test: /\.scss$/,
                use: [
                    MiniCSSExtractPlugin.loader,
                    { loader: 'css-loader', options: { sourceMap: true } },
                    { loader: 'sass-loader', options: { sourceMap: true } },
                    {
                        loader: 'style-resources-loader', options: {
                            patterns: [
                                // eslint-disable-next-line no-undef
                                path.resolve(__dirname, '../scss/resources.scss'),
                            ],
                        }
                    },
                ]
            },
        ]
    },
    stats: {
        children: false,
        colors: true
    },
    devtool: 'source-map',
    resolve: {
        extensions: ['.js', '.vue'],
        alias: {
            vue: 'vue/dist/vue.js',
            // eslint-disable-next-line no-undef
            '@': path.join(__dirname, './js/'),
            // eslint-disable-next-line no-undef
            '@areas': path.join(__dirname, './areas/'),
            '@core': '@areas/core/',
        }
    },
};

module.exports = config;
