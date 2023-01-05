module.exports.db=new server.ConnectionPool({
    server:'192.168.171.36',
    database :'3309',
    driver:'msnodesqlv8',
    options:{

        trustedConnection:true,
        TrustServerCertificate:true
    }
})