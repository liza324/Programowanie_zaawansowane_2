module.exports = function (config) {
  config.set({
    frameworks: ["jasmine"],
    files: ["*.ts", "*.spec.ts"],
    plugins: ["karma-jasmine"],
    reporters: ["dots"],
    color: true,
    singleRun: true,
  });
};
